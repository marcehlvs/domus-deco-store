document.addEventListener("DOMContentLoaded", () => {

    const form = document.querySelector(".producto-form");
    if (!form) return;

    const inputImg = form.querySelector("#ImagenUrl");
    const previewImg = form.querySelector("#previewImg");
    const previewIcon = form.querySelector("#previewIcon");
    const previewText = form.querySelector("#previewText");

    if (!inputImg) return;

    inputImg.addEventListener("input", () => {
        const url = inputImg.value.trim();

        if (url) {
            previewImg.src = url;
            previewImg.style.display = "block";
            previewIcon.style.display = "none";
            previewText.style.display = "none";
        } else {
            previewImg.style.display = "none";
            previewIcon.style.display = "block";
            previewText.style.display = "block";
        }
    });
});
