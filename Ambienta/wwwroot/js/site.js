document.addEventListener('DOMContentLoaded', function () {
    // Alternar íconos y sublistas al hacer clic en .toggle-btn
    document.querySelectorAll('.toggle-btn').forEach(btn => {
        btn.addEventListener('click', function (event) {
            event.stopPropagation(); // Previene que el evento se propague al documento

            const sublist = this.nextElementSibling;
            const downIcon = this.querySelector('.bi-caret-down-fill');
            const upIcon = this.querySelector('.bi-caret-up-fill');

            // Alternar ícono y sublista del elemento actual
            if (downIcon && upIcon && sublist) {
                const isVisible = sublist.style.display === "block";

                closeOtherSublists(this); // Cierra todas las sublistas excepto la actual
                if (!isVisible) { // Si estaba cerrada, abrir y cambiar iconos
                    downIcon.style.display = "none";
                    upIcon.style.display = "inline";
                    sublist.style.display = "block";
                }
            }
        });
    });

    // Función para cerrar otras sublistas cuando se abre una nueva
    function closeOtherSublists(currentBtn) {
        document.querySelectorAll('.toggle-btn').forEach(function (link) {
            if (link !== currentBtn) { // Solo cierra las sublistas que no son la actual
                const downIcon = link.querySelector('.bi-caret-down-fill');
                const upIcon = link.querySelector('.bi-caret-up-fill');
                const sublist = link.nextElementSibling;

                if (downIcon && upIcon && sublist) {
                    downIcon.style.display = "inline";
                    upIcon.style.display = "none";
                    sublist.style.display = "none";
                }
            }
        });
    }

    // Evitar que el clic en la sublista cierre su propio menú
    document.querySelectorAll('.sublista').forEach(sublist => {
        sublist.addEventListener('click', function (event) {
            event.stopPropagation(); // Evita que el clic dentro de la sublista cierre el menú
        });
    });

    // Gestionar scrollspy para abrir/cerrar sublistas basándose en la ubicación del scroll
    document.body.addEventListener('activate.bs.scrollspy', function (event) {
        const activeElement = document.querySelector('.nav-link.active');
        if (!activeElement) return; // Salir si no hay un elemento activo

        const sublist = activeElement.closest('.nav-item')?.querySelector('.sublista');

        // Cierra todas las sublistas y restablece íconos primero
        document.querySelectorAll('.sublista').forEach(function (sublista) {
            sublista.style.display = 'none';
            const parentBtn = sublista.previousElementSibling;
            const downIcon = parentBtn.querySelector('.bi-caret-down-fill');
            const upIcon = parentBtn.querySelector('.bi-caret-up-fill');

            // Restablecer íconos
            if (downIcon && upIcon) {
                downIcon.style.display = 'inline';
                upIcon.style.display = 'none';
            }
        });

        // Abre la sublista correspondiente y ajusta los íconos
        if (sublist) {
            sublist.style.display = 'block';
            const parentBtn = sublist.previousElementSibling;
            const downIcon = parentBtn.querySelector('.bi-caret-down-fill');
            const upIcon = parentBtn.querySelector('.bi-caret-up-fill');

            if (downIcon && upIcon) {
                downIcon.style.display = 'none';
                upIcon.style.display = 'inline';
            }
        }
    });

    // Actualizar ScrollSpy al cambiar pestañas
    document.querySelectorAll('#nav-tab>[data-bs-toggle="tab"]').forEach(el => {
        el.addEventListener('shown.bs.tab', () => {
            const target = el.getAttribute('data-bs-target');
            const scrollElem = document.querySelector(`${target} [data-bs-spy="scroll"]`);
            setTimeout(() => bootstrap.ScrollSpy.getOrCreateInstance(scrollElem).refresh(), 10); // Actualización con un pequeño retraso
        });
    });
});
