using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Threading.Tasks;
using pManagement.Properties;
using System.Collections.ObjectModel;
using System.Data.Services.Client;
using System.Net;
using pManagement.ServiceReference1;

namespace pManagement
{
      

    public partial class Lärmkataster_Form : Form
    {
        DomainModelContext _context;
        private  DataServiceCollection<NoiseMeasurement> _measurements;
        private  DataServiceCollection<MeasuringMethod> _methods;
        private  DataServiceCollection<MeasuringPoint> _points;
        private  DataServiceCollection<NoiseMapPosition> _position;
        private  DataServiceCollection<NoiseMap> _map;
        private  DataServiceCollection<pManagement.ServiceReference1.File> _file;  
             
        public ObservableCollection<MeasuringPoint> Points { get { return _points; } }
        public ObservableCollection<NoiseMapPosition> Position { get { return _position; } }
        public ObservableCollection<NoiseMap> Map { get { return _map; } }
        public ObservableCollection<pManagement.ServiceReference1.File> File { get { return _file; } }
        public ObservableCollection<NoiseMeasurement> Measurements { get { return _measurements; } }
        public ObservableCollection<MeasuringMethod> Methods { get { return _methods; } }

        private string pathImage = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\hallenplan_2.JPG";

        private Position Pos;
        public int Xpos { get; set; } int Ypos { get; set; }
        private Image bmp;

        
        public Lärmkataster_Form()
        {
            InitializeComponent();
            UpdateForm();
            //this.PBMap.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            this.PBMap.MouseClick+=pictureBox1_Click;
            this.PBMap.Paint += pictureBox1_Paint;
            this.PBPoints.MouseMove += PBPoints_MouseMove;
            this.PBPoints.MouseClick += PBPoints_MouseClick;
            this.PBPoints.Paint += PBPoints_Paint;
            this.LBMethods.SelectedIndexChanged +=LBMethods_SelectedIndexChanged;          
        }

        public void UpdateForm()
        {          
            _context = new DomainModelContext(new Uri("http://141.45.92.171:7000/OpenResKitHub"));
            _context.Credentials = new NetworkCredential("root", "ork123");
            _points = new DataServiceCollection<MeasuringPoint>(_context.MeasuringPoints);            
            _measurements = new DataServiceCollection<NoiseMeasurement>(_context.NoiseMeasurements);   
            _position=new DataServiceCollection<NoiseMapPosition>(_context.NoiseMapPositions);
            _map=new DataServiceCollection<NoiseMap>(_context.NoiseMaps);
            _file=new DataServiceCollection<ServiceReference1.File>(_context.Files);
            _methods = new DataServiceCollection<MeasuringMethod>(_context.MeasuringMethods);
            
            this.bmp = new Bitmap(pathImage);
            PBMap.Image = bmp;
            PBPoints.Image = bmp;
            //Draw();

            CBChoosePosition.DataSource = Points;
            CBChoosePosition.DisplayMember= "Name";
            CBMessPoints.DataSource = Points;
            CBMessPoints.DisplayMember = "Name";
            comboBox1.DataSource = Methods;
            comboBox1.DisplayMember = "Name";
            LBMethods.DataSource = Methods;
            LBMethods.DisplayMember = "Name";
            dataGridView1.DataSource = Measurements;
        }
 

        private void Draw(Position Pos)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {



                IEnumerable<NoiseMapPosition> EnumPosition = _context.NoiseMapPositions;
                foreach (NoiseMapPosition item in EnumPosition)
                {
                    Color Farbe = Color.Black;
                    //if (Convert.ToInt16(item.Element("Average").Value) < 30)
                    //    Farbe = Color.GreenYellow;
                    //else if (Convert.ToInt16(item.Element("Average").Value) < 60)
                    //    Farbe = Color.Orange;
                    //else if (Convert.ToInt16(item.Element("Average").Value) > 59)
                    //    Farbe = Color.Red;

                    //if (Pos.XWert == Convert.ToInt16(item.Element("XWert").Value) &&
                    //    Pos.YWert == Convert.ToInt16(item.Element("YWert").Value))
                    //{
                        g.DrawLine(new Pen(Farbe, 20), Pos.XWert * bmp.Width / pictureBox1.Width,
                        Pos.YWert * bmp.Height / pictureBox1.Height, (Pos.XWert + 5) * bmp.Width / pictureBox1.Width,
                        (Pos.YWert + 5) * bmp.Height / pictureBox1.Height);

                        g.Flush();

                        pictureBox1.Invalidate();
                //string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\dbwerte.xml";

                //XElement root = XElement.Load(@path);
                //IEnumerable<XElement> elements = root.Elements();
                //foreach (XElement item in elements)
                //{
                //    Color Farbe=Color.Black;
                //    if (Convert.ToInt16(item.Element("Average").Value) < 30)
                //        Farbe = Color.GreenYellow;
                //    else if (Convert.ToInt16(item.Element("Average").Value) < 60)
                //        Farbe = Color.Orange;
                //    else if (Convert.ToInt16(item.Element("Average").Value) > 59)
                //        Farbe = Color.Red;

                //    if (Pos.XWert == Convert.ToInt16(item.Element("XWert").Value) &&
                //        Pos.YWert == Convert.ToInt16(item.Element("YWert").Value))
                //    {
                //        g.DrawLine(new Pen(Farbe, 20), Pos.XWert * bmp.Width / pictureBox1.Width,
                //        Pos.YWert * bmp.Height / pictureBox1.Height, (Pos.XWert + 5) * bmp.Width / pictureBox1.Width,
                //        (Pos.YWert + 5) * bmp.Height / pictureBox1.Height);
                        
                //        g.Flush();

                //        pictureBox1.Invalidate();
                        
                        //pictureBox1.Image.
                    //}
                }
            }      
        }

        private void Draw()
        {


            using (Graphics g = Graphics.FromImage(bmp))
            {
                IEnumerable<NoiseMeasurement> elements = _measurements;
                foreach (NoiseMeasurement item in elements)
                {
                    Color Farbe = Color.Black;
                    if (item.AverageValue< 30)
                        Farbe = Color.GreenYellow;
                    else if (Convert.ToInt16(item.AverageValue) < 60)
                        Farbe = Color.Orange;
                    else if (item.AverageValue > 59)
                        Farbe = Color.Red;


                    //g.DrawLine(new Pen(Farbe, 20),
                    if(item.MeasuringPoint!=null)
                    Convert.ToInt16(item.MeasuringPoint.Position.XPosition);//*bmp.Width/pictureBox1.Width,
                    //    //Convert.ToInt16(item.Element("YWert").Value)*bmp.Height/pictureBox1.Height,
                    //    //(Convert.ToInt16(item.Element("XWert").Value) + 5)*bmp.Width/pictureBox1.Width,
                    //    //(Convert.ToInt16(item.Element("YWert").Value) + 5)*bmp.Height/pictureBox1.Height);

                    g.Flush();

                    //pictureBox1.Invalidate();
                    //PBPoints.Invalidate();
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //Xpos = e.X*bmp.Width/PBMap.Width;
            //Ypos = e.Y *bmp.Height / PBMap.Height;
            //Pos= new Position(Xpos,Ypos);
            //TBXWert.Text = Convert.ToString(Xpos);
            //TBYWert.Text = Convert.ToString(Ypos);
        }
        private void PBPoints_MouseMove(object sender, MouseEventArgs e)
        {
            Xpos = e.X * bmp.Width / PBPoints.Width;
            Ypos = e.Y * bmp.Height / PBPoints.Height;
            Pos = new Position(Xpos, Ypos);
            TBPointsX.Text = Convert.ToString(Xpos);
            TBPointsY.Text = Convert.ToString(Ypos);
        }
        private void PBPoints_Paint(object sender, PaintEventArgs e)
        {
        }
        private void PBPoints_MouseClick(object sender, MouseEventArgs e)
        {
            PBPoints.MouseMove -= PBPoints_MouseMove;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {   
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
        }
 
        #region Messmethoden verwalten

        private void BMethodAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MeasuringMethod temp = new MeasuringMethod();
                temp.Description = TBMethodDescription.Text;
                temp.Name = TBMethodName.Text;

                _context.AddObject("MeasuringMethods", temp);
                _context.SaveChanges();

                LMethodInvalid.Visible = false;
                TBMethodName.Clear();
                TBMethodDescription.Clear();
                UpdateForm();


            }
            catch (Exception)
            {
                LMethodInvalid.Visible = true;
                
            }


        }

        private void BMethodCancel_Click(object sender, EventArgs e)
        {
            LMethodInvalid.Visible = false;
            TBMethodName.Clear();
            TBMethodDescription.Clear();
        }

        private void LBMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            MeasuringMethod temp = (MeasuringMethod)LBMethods.SelectedItem;
            TBMethodDescription.Text = temp.Description;
            TBMethodName.Text = temp.Name;
        }

        private void BMethodsDelete_Click(object sender, EventArgs e)
        {
            MeasuringMethod temp = (MeasuringMethod)LBMethods.SelectedItem;
            _methods.Remove(temp);
            _context.SaveChanges();
            UpdateForm();
        }

        #endregion

        #region Messungen speichern

        private void BSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                MeasuringMethod MM =new MeasuringMethod();
                foreach(MeasuringMethod item in Methods)
                {
                    if(item==comboBox1.SelectedItem) MM=item;          
                }

                float average = (float)Convert.ToDouble(TBAverage.Text);
                float max = (float)Convert.ToDouble(TBMaxWert.Text);
                float min = (float)Convert.ToDouble(TBMinWert.Text);
                if (average < 0 || average > 150 || average >= max || average <= min || max <= min || max > 150 || min < 0)
                    throw new Exception();

                NoiseMeasurement M = new NoiseMeasurement();             
                M.AverageValue = average;
                M.MaxValue = max;
                M.MinValue = min;
                M.MeasurementDate = dateTimePicker1.Value;
                M.Method = (MeasuringMethod) comboBox1.SelectedItem;
                M.MeasuringPoint = (MeasuringPoint) CBChoosePosition.SelectedItem;
                M.Employee = TBEmployee.Text;
                _context.AddToNoiseMeasurements(M);
                //_context.AddObject("NoiseMeasurements", M);
                //_context.SetLink(M, "MeasuringPoint", O);
                //_context.SetLink(M, "MeasuringPoint", O);   //      Warum funktioniert die Zuweisung nicht?  
                
              //  _context.AddRelatedObject(M, "MeasuringPoint", O);
                //   Versuch der Zuweisung mit Daten des Servers (funktioniert nicht)  
                //_context.SetLink(_context.NoiseMeasurements.Last<NoiseMeasurement>(), "Method", _context.MeasuringMethods.Last<MeasuringMethod>());            
            //    _context.AddRelatedObject(M, "Method", MM);
                _context.SaveChanges();
                PBMap.MouseMove += pictureBox1_MouseMove;
                TBAverage.Clear();
                TBMaxWert.Clear();
                TBMinWert.Clear();
      
                UpdateForm();
                LDataInvalid.Visible = false;
            }
            catch (Exception)
            {
                LDataInvalid.Visible=true;
                BClearTBData_Click(null,null);
            }          
        }               

        private void BClearTBData_Click(object sender, EventArgs e)
        {
            PBMap.MouseMove += pictureBox1_MouseMove;
            TBMaxWert.Clear();
            TBMinWert.Clear();
            TBAverage.Clear();
            TBEmployee.Clear();
        }
        
        #endregion
 
        #region Messpunkte/orte
        private void BMessPointAdd_Click(object sender, EventArgs e)
        {
            try
            {
                NoiseMapPosition P = new NoiseMapPosition();
                P.XPosition = Convert.ToInt16(TBPointsX.Text);
                P.YPosition = Convert.ToInt16(TBPointsY.Text);
                _context.AddToNoiseMapPositions(P);

                MeasuringPoint O = new MeasuringPoint();
                //_context.AddObject("MeasuringPoints", O);
                //_context.AddRelatedObject(_points, "Position", _position);

                O.Name = TBPointsName.Text;
                O.Notes = TBPointsDescription.Text;
                O.Position = P;
                _context.AddToMeasuringPoints(O);
                //_context.SetLink(O, "Position", P);
                //_context.AddRelatedObject(Points, "Position", Position);
                //_context.SetLink(O, "Position", P);               //Warum funktioniert die Zuweisung nicht? Lokal waere O.Position=P; 
                _context.SaveChanges();

                TBPointsDescription.Clear();
                TBPointsName.Clear();
                TBPointsX.Clear();
                TBPointsY.Clear();
                PBPoints.MouseMove += PBPoints_MouseMove;
                UpdateForm();
            }
            catch (Exception)
            {
                LPointsDataInvalid.Visible = true;
                TBPointsDescription.Clear();
                TBPointsName.Clear();
                TBPointsX.Clear();
                TBPointsY.Clear();
                PBPoints.MouseClick += PBPoints_MouseClick;
            }
        }

        private void BMessPointCancel_Click(object sender, EventArgs e)
        {
            TBPointsX.Clear();
            TBPointsY.Clear();
            TBPointsName.Clear();
            TBPointsDescription.Clear();
            PBPoints.MouseClick += PBPoints_MouseClick;
        }

        private void BMessPointDelete_Click(object sender, EventArgs e)
        {
            _points.Remove((MeasuringPoint) CBMessPoints.SelectedItem);
            _context.SaveChanges();
            UpdateForm();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e) { }

        private void BDeleteMeasurements_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            { _measurements.RemoveAt(item.Index); }    
            _context.SaveChanges();
            UpdateForm();
        }
    }
}
