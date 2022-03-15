<?php


require_once "parte_head.php";
?>

<body>


    <?php
    require_once "parte_menu.php";
    ?>
    <div class="container">
        <h3><?php echo $pagina; ?></h3>
        <div class="row">
            <form class="col-6" method="post">
                <div class="mb-3">
                    <label for="">Ciudad</label>
                    <input type="text" name="city" class="form-control">
                </div>
                <br>

            <class="col-6" method="post">
                <div class="mb-3">
                    <label for="">direccion de paises</label> 
                </div>
                
                <div class="mb-3">
                <select class="form-select" name="country_id">
                    <option value="" selected>Seleccione</option>

                    <?php

                    $query ="SELECT * FROM city";

                    $resultado = mysqli_query($conexion, $query);

                    if ($resultado) {
                        while ($fila = mysqli_fetch_object($resultado)) {
                            echo "<option value='$fila->last_update'>$fila->country_id</option>";
                        }
                    }

                    ?>
                </select>
                </div>
                <br>

                <button name=boton-guardar class="btn btn-outline-secondary">Guardar</button>
            </form>

            <?php if (!empty($error)): ?>
            <div class="alert alert-warning alert-dismissible fade show" role="alert">
                <?php echo $error; ?>
                <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
            </div>
            <?php endif; ?>

        </div>
        <?php
        require_once "parte_footer.php"
        ?>
    </div>
</body>

</html>