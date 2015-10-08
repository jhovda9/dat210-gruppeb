<?php 

$db_server = "localhost";
$db_username = "root";
$db_password = "";
$db_database = "dat210_server";

#lagrer tilkoblingsinformasjonen i et connect objekt
$conn = mysqli_connect($db_server, $db_username, $db_password, $db_database);

if (!$conn) {  # Sjekker om du klarer og koble deg til serveren. Viss ikke gis feilmelding
    die("Connection failed: " . mysqli_connect_error());
}
echo "Connected successfully <br>";

#Post for å hente evt finne verdier som trengs
$search = isset($_POST['search']) ? $_POST['search'] : "";

# Dette er et søk, men kan brukes til f.eks til å lagre istede for
$sql = "SELECT * FROM Informasjon WHERE noe = " . "'$search'"; 

#selve utførselen av søket og returnerer funn
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

#Lukker tilkoblingen
mysqli_close($conn);
?>
