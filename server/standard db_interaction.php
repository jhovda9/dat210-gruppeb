<?php 

$db_server = "localhost";
$db_username = "root";
$db_password = "";
$db_database = "dat210_server";

$conn = mysqli_connect($db_server, $db_username, $db_password, $db_database);

if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}
echo "Connected successfully <br>";

$sql = "SELECT * FROM Informasjon WHERE noe = " . "'$search'"; # Dette er et søk, men can brukes til å sette inn, 
$result = mysqli_query($conn, $sql);
if (mysqli_num_rows($result) > 0) {
   	echo "Foelgende treff paa " . $search . ": <br>";
   	while($row = mysqli_fetch_assoc($result)) {
       	echo $row['rowname'] . "<br>";
   	}
} else {
   	echo " <br> Ingen treff paa " . $search . "<br>";
   	$row = mysqli_fetch_assoc($result); 
   	echo $row['rowname'];
}

mysqli_close($conn);

?>
