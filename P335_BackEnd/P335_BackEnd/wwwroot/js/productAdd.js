const imgInput = document.querySelector('.img-input');
const imgPreview = document.querySelector('.img-preview');

imgInput.addEventListener('change', (e) => {
    imgPreview.innerHTML = '';

    for (const file of e.target.files) {
        const img = document.createElement('img');
        img.width = 200;
        img.height = 200;

        const blobUrl = URL.createObjectURL(file);
        img.src = blobUrl;

        imgPreview.appendChild(img);
    }
});