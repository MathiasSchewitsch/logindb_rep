<?php 
session_start();

	include("connection.php");
	include("functions.php");

	$user_data = check_login($con);

?>

<!DOCTYPE html>
<html>
<head>
	<link rel="stylesheet" href="stylelogin.css">
	<title>My website</title>
</head>
<body>
	<div class="logout">
		<a href="logout.php">Logout</a>
	</div>
	<div class="pagehead">
			<h1>Doom with Waves</h1>
	</div>

	<br>
		Hello, <?php echo $user_data['user_name']; ?>
	</br>
	<p>Click download button down bellow, to download and start playing Doom with Waves!!! (game is still in alpha)</p>
	<a download="test.txt" href="info.txt" title="DownloadButton">
		<img alt="DownloadButton" src="download.jpg" style="width:15%">
	</a>

</body>
</html>