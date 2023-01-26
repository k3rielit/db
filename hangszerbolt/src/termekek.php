<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>BADERBOLT</title>
    <link rel="icon" type="image/jpg" href="kepek/h4n.jpg" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
</head>

<body style="background: #ececec;">
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="container-fluid">
            <a class="navbar-brand" href="index.php"><s>BADERBOLT Bt</s> MUZIKER</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup"
                aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                <div class="navbar-nav">
                    <a class="nav-link active" aria-current="page" href="index.php"
                        id="navBemutatkozas">Bemutatkozás</a>
                    <a class="nav-link disabled" href="#" id="navKapcsolat5">Kapcsolat</a>
                    <a class="nav-link disabled" href="#" id="navForum">Fórum</a>
                    <a class="nav-link" href="termekek.php" id="navTermekek">Termékek</a>
                </div>
            </div>
        </div>
    </nav>

    <!-- szigorú a tesst -->
    <div class="container">

        <div class="row">&nbsp;</div>

        <!-- test -->
        <div class="row">
          <div class="col-3"></div>
          <div class="col-6">
              <div class="card text-center">
                  <div class="card-header">
                    AKCIÓ!
                  </div>
                  <div class="card-body">
                    <h5 class="card-title">-50% kedvezmény</h5>
                    <p class="card-text">A nemzeti badernap alkalmából minden kedves vásárlónak 50% kedvezményt adunk a BADER2021 kuponnal!</p>
                    <a href="https://youtu.be/dQw4w9WgXcQ" target="_blank" class="btn btn-primary">Beváltás</a>
                  </div>
                  <div class="card-footer text-muted">
                    1 nap van hátra
                  </div>
                </div>
          </div>
          <div class="col-3"></div>
        </div>
        <!-- /test -->

        <div class="row">&nbsp;</div>

        <div class="row">
          <div class="col-12">
            <div class="accordion">
              <!-- PHP lekérések eredménye -->
<?php
$conn = new mysqli("localhost", "root", "", "hangszerbolt");
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}

$sql = "SELECT * FROM hangszer";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
  while($row = $result->fetch_assoc()) {
    //print("<tr><td>".$row["id"]."</td><td>".$row["firstname"]." ".$row["lastname"]."</td></tr>";
    print('<div class="accordion-item"><h2 class="accordion-header"><button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#ai-'.$row["sorszam"].'" aria-expanded="true" aria-controls="ai-'.$row["sorszam"].'">');
    print('<span class="badge rounded-pill bg-primary">'.$row["kategoria"].'</span> &nbsp;'.$row["nev"]);
    print('</button></h2>');

    print('<div id="ai-'.$row["sorszam"].'" class="accordion-collapse collapse"><div class="accordion-body">');

    print('<div class="card"><h5 class="card-header">'.$row["leiras"].'</h5><div class="card-body">');
    print('      <h5 class="card-title"><b>'.$row["ar"].'</b> HUF</h5><p class="card-text">'.$row["sorszam"].' - '.$row["datum"].'</p><a href="https://youtu.be/dQw4w9WgXcQ" target="_blank" class="btn btn-primary">Kosárba</a>');

    print('</div></div></div></div></div>');
  }
} else {
  print("Nincsenek találatok!");
}
$conn->close();
?>
              <!-- /PHP lekérések eredménye -->
            </div>
          </div>
        </div>

        <div class="row">&nbsp;</div>

    </div>

<!-- footer -->
<footer class="text-center text-lg-start bg-light text-muted">
    <section class="d-flex justify-content-center justify-content-lg-between p-4 border-bottom">
      <div class="me-5 d-none d-lg-block">
        <span>További információk</span>
      </div>
    </section>
    <section class="">
      <div class="container text-center text-md-start mt-5">
        <div class="row mt-3">
          <div class="col-md-3 col-lg-4 col-xl-3 mx-auto mb-4">
            <h6 class="text-uppercase fw-bold mb-4">
              <i class="fas fa-gem me-3"></i>(c) BaderBolt Bt. 2077
            </h6>
            <p>
              Cégünk már 1956 óta árul kiváló minőségű hangszereket, és ezen nem tervezünk változtatni a közeljövőben sem!
            </p>
          </div>
          <div class="col-md-3 col-lg-2 col-xl-2 mx-auto mb-4">
            <h6 class="text-uppercase fw-bold mb-4">
              Linkek
            </h6>
            <p>
              <a href="index.php" class="text-reset">Bemutatkozás</a>
            </p>
            <p>
              <a href="#" class="text-reset">Kapcsolat</a>
            </p>
            <p>
              <a href="#" class="text-reset">Fórum</a>
            </p>
            <p>
              <a href="termekek.php" class="text-reset">Termékek</a>
            </p>
          </div>
          <div class="col-md-4 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4">
            <h6 class="text-uppercase fw-bold mb-4">
              Kapcsolat
            </h6>
            <p><i class="fas fa-home me-3"></i>69305 Gyöngyös, Duranda negyed</p>
            <p>
              <i class="fas fa-envelope me-3"></i>
              kapcsolat@baderhangszerek.hu
            </p>
            <p><i class="fas fa-phone me-3"></i> +36 30 11 33 966</p>
          </div>
        </div>
      </div>
    </section>
  </footer>

    <!-- szxszript -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"
        crossorigin="anonymous"></script>
</body>

</html>