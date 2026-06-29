const menuBtn = document.getElementById("menuBtn");
        const closeBtn = document.getElementById("closeBtn");
        const sidebar = document.getElementById("sidebar");

        // TOGGLE SIDEBAR
        menuBtn.addEventListener("click", () => {
            sidebar.classList.toggle("hide");
        });

        // CLOSE SIDEBAR
        closeBtn.addEventListener("click", () => {
            sidebar.classList.add("hide");
        });