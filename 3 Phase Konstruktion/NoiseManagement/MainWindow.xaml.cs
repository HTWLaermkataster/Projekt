using System;
using System.Collections.ObjectModel;
using System.Data.Services.Client;
using System.Net;
using System.Windows;
using NoiseManagement.DataContext;

namespace NoiseManagement
{
  /// <summary>
  ///   Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private readonly DomainModelContext _context;
    private readonly DataServiceCollection<NoiseEmployee> _employees;

    public MainWindow()
    {
      DataContext = this;
      _context = new DomainModelContext(new Uri("http://141.45.92.171:7000/OpenResKitHub"));
      _context.Credentials = new NetworkCredential("root", "ork123");
      _employees = new DataServiceCollection<NoiseEmployee>(_context);
      DataServiceQuery<NoiseEmployee> query = _context.NoiseEmployees;
      _employees.Load(query);
      InitializeComponent();

      _employees.Add(new NoiseEmployee
      {
        FirstName = "Arschloch"
      });
      Save();
    }

    public ObservableCollection<NoiseEmployee> Employees
    {
      get { return _employees; }
    }

    private void Save()
    {
      IAsyncResult result = _context.BeginSaveChanges(SaveChangesOptions.Batch, r =>
      {
        var dm = (DomainModelContext) r.AsyncState;
        dm.EndSaveChanges(r);
      }, _context);
    }
  }
}