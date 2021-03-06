
function toggleCollapsible() {
    var coll = document.getElementsByClassName("collapsible");
    var i;

    for (i = 0; i < coll.length; i++) {
        coll[i].addEventListener("click", function () {
            this.classList.toggle("active");
            var content = this.nextElementSibling;
            if (content.style.maxHeight) {
                content.style.maxHeight = null;
                this.children[0].classList.remove('fa-arrow-down');
                this.children[0].classList.add('fa-arrow-up');
            } else {
                content.style.maxHeight = content.scrollHeight + "px";
                this.children[0].classList.remove('fa-arrow-up');
                this.children[0].classList.add('fa-arrow-down');
            }
        });
    }
}
