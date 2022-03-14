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
                    <label for="">Clientes</label>
                    <input type="text" name="first_name" class="form-control">
                </div>
                <br>

                <div class="mb-3">
                    <label for="">Apellidos de los clientes</label>
                    <input type="text" name="last_name" class="form-control">
                </div>
                <br>

                <div class="mb-3">
                    <label for="">coreo de los clientes</label>
                    <input type="text" name="email" class="form-control">
                </div>
                <br>

            <form class="col-6" method="post">
                <div class="mb-3">
                    <label for="">direccion de los clientes</label>
                </div>

                <div class="mb-3">
                <select class="form-select" name="id">
                    <option value="" selected>Seleccione</option>

                    <?php

                    $query ="SELECT * FROM customer";

                    $resultado = mysqli_query($conexion, $query);

                    if ($resultado) {
                        while ($fila = mysqli_fetch_object($resultado)) {
                            echo "<option value='$fila->id'>$fila->address_id</option>";
                        }
                    }

                    ?>
                </select>
                </div>
                <br>

                    <button name=boton-guardar class="btn btn-outline-secondary">Guardar</button>
                </div>
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