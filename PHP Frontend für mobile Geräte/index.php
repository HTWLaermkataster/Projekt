<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<?php
echo '<meta http-equiv="refresh" content=';
$timestamp = time();
$i=date("s",$timestamp);
$mi = 60 -  $i;
echo '"' . $mi . '; URL=./">';
?>

<link href="./favicon.ico" rel="shortcut icon" type="image/ico" />
<link rel="icon" href="./favicon.ico" type="image/ico" />

<title>
<?php
$datum = date("d.m.Y",$timestamp);
$uhrzeit = date("H:i:s",$timestamp);

$Text = $uhrzeit . " - " . $datum;

echo $Text;
?>
</title>
</head>

<body>
<?php

$id = dba_open("/tmp/test.db", "w", "db4");

//phpinfo();

if (!$id) {
    echo "dba_open db4 schlug fehl\n";
    exit;
}

$Schluessel = "Key123";
$Text = "Schallpegel in dB";

$X=htmlspecialchars($_POST["X"]);
$MS=htmlspecialchars($_POST["MS"]);

if($i==0)
{
	echo "<h1>Hello " . $X . "!<br />Number: " . $MS . "</h1><p>";
}
else
{
	echo "<h1>Bitte warten...</h1><p>";
}
dba_replace($Schluessel, $Text, $id);

if (dba_exists($Schluessel, $id)) {
    echo dba_fetch($Schluessel, $id);
//    dba_delete("schluessel", $id);
}

echo "</p>";
//echo "<p>";
// echo dba_info($id);
//echo "</p>";

dba_close($id);

//<br /><a href="./phpMyAdmin/index.php">Zum Admin!</a>
//<br /><a href="./index.php">Zum Deivi!</a>
//<a>Meßstelle</a>
?>

<form action="./" method="POST">
<input type="text" name="X">
<br />
<br />
<input type="submit" name="MS" value="MS 1">
<input type="submit" name="MS" value="MS 2">
<input type="submit" name="MS" value="MS 3">
<br />
<input type="submit" name="MS" value="MS 4">
<input type="submit" name="MS" value="MS 5">
<input type="submit" name="MS" value="MS 6">
<br />
<input type="submit" name="MS" value="MS 7">
<input type="submit" name="MS" value="MS 8">
<input type="submit" name="MS" value="MS 9">
</form>
<p><img alt="Energieerzeugung" src="./chart.jpg" /></p>
</body>
</html>
