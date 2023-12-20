/*=============== LOGIN - REGISTER ===============*/
const PortalFormWarp = document.querySelector('.portal-form-wrap');
const LoginLink = document.querySelector('.login-link');
const RegisterLink = document.querySelector('.register-link');

RegisterLink.addEventListener('click', () => {
    PortalFormWarp.classList.add('active');
});

LoginLink.addEventListener('click', () => {
    PortalFormWarp.classList.remove('active');
});

/*=============== SEARCH ===============*/
const searchButton = document.getElementById("search-button"),
    searchClose = document.getElementById("search-close"),
    searchContent = document.getElementById("search-content");

if (searchButton) {
    searchButton.addEventListener("click", () => {
        searchContent.classList.add("show-search");
    });
}

if (searchClose) {
    searchClose.addEventListener("click", () => {
        searchContent.classList.remove("show-search");
    });
}

/*=============== ADD SHADOW HEADER ===============*/
const shadowHeader = () => {
    const header = document.getElementById("header");
    this.scrollY >= 50
        ? header.classList.add("shadow-header")
        : header.classList.remove("shadow-header");
};
window.addEventListener("scroll", shadowHeader);
/*=============== HOME SWIPER ===============*/
let swiperHome = new Swiper(".home__swiper", {
    loop: true,
    spaceBetween: -24,
    grabCursor: true,
    slidesPerView: "auto",
    centeredSlides: "auto",

    autoplay: {
        delay: 3000,
        disableOnInteraction: false,
    },

    breakpoints: {
        1220: {
            spaceBetween: -32,
        },
    },
});

/*=============== FEATURED SWIPER ===============*/
let swiperFeatured = new Swiper(".featured__swiper", {
    loop: true,
    spaceBetween: 16,
    grabCursor: true,
    slidesPerView: "auto",
    centeredSlides: "auto",

    navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
    },

    breakpoints: {
        1150: {
            slidesPerView: 4,
            centeredSlides: false,
        },
    },
});

/*=============== NEW SWIPER ===============*/
let swiperNew = new Swiper(".new__swiper", {
    loop: true,
    spaceBetween: 16,
    slidesPerView: "auto",

    breakpoints: {
        1150: {
            slidesPerView: 3,
        },
    },
});
/*=============== TESTIMONIAL SWIPER ===============*/
let swiperTestimonial = new Swiper(".testimonial__swiper", {
    loop: true,
    spaceBetween: 16,
    grabCursor: true,
    slidesPerView: "auto",
    centeredSlides: "auto",

    breakpoints: {
        1150: {
            slidesPerView: 3,
            centeredSlides: false,
        },
    },
});
/*=============== SHOW SCROLL UP ===============*/
const scrollUp = () => {
    const scrollUp = document.getElementById("scroll-up");
    this.scrollY >= 350
        ? scrollUp.classList.add("show-scroll")
        : scrollUp.classList.remove("show-scroll");
};
window.addEventListener("scroll", scrollUp);
/*=============== SCROLL SECTIONS ACTIVE LINK ===============*/
const sections = document.querySelectorAll("section[id]");

const scrollActive = () => {
    const scrollDown = window.scrollY;

    sections.forEach((current) => {
        const sectionHeight = current.offsetHeight,
            sectionTop = current.offsetTop - 58,
            sectionId = current.getAttribute("id"),
            sectionClass = document.querySelector(
                `.nav__menu a[href*= ${sectionId}]`
            );
        if (scrollDown > sectionTop && scrollDown <= sectionTop + sectionHeight) {
            sectionClass.classList.add("active_link");
        } else {
            sectionClass.classList.remove("active_link");
        }
    });
};
window.addEventListener("scroll", scrollActive);

/*=============== DARK LIGHT THEME ===============*/
const themeButton = document.getElementById("theme-button");
const darkTheme = "dark-theme";
const iconTheme = "ri-sun-line";
const selectedTheme = localStorage.getItem("selected-theme");
const selectedIcon = localStorage.getItem("selected-icon");

const getCurrentTheme = () =>
    document.body.classList.contains(darkTheme) ? "dark" : "light";
const getCurrentIcon = () =>
    themeButton.classList.contains(iconTheme) ? "ri-sun-line" : "ri-moon-line";

if (selectedTheme) {
    document.body.classList[selectedTheme === "dark" ? "add" : "remove"](
        darkTheme
    );
    themeButton.classList[selectedIcon === "ri-moon-line" ? "add" : "remove"](
        iconTheme
    );
}

themeButton.addEventListener("click", () => {
    document.body.classList.toggle(darkTheme);
    themeButton.classList.toggle(iconTheme);
    localStorage.setItem("selected-theme", getCurrentTheme());
    localStorage.setItem("selected-icon", getCurrentIcon());
});
/*=============== SCROLL REVEAL ANIMATION ===============*/
const sr = ScrollReveal({
    origin: "top",
    distance: "60px",
    duration: "2500",
    delay: "400",
    reset: true,
});

sr.reveal(`.home__data, .featured__container, .new__container,
            .join__data, .testimonial__container, .footer`);
sr.reveal(`.home__images`, { delay: 600 });
sr.reveal(`.services__card`, { interval: 100 });
sr.reveal(`.discount__data`, { origin: "left" });
sr.reveal(`.discount__images`, { origin: "right" });

/*=============== EDIT-PROFILE ===============*/
const editButton = document.getElementById("edit-info"),
    editClose = document.getElementById("edit-close"),
    editContent = document.getElementById("edit-profile");

if (editButton) {
    editButton.addEventListener("click", () => {
        editContent.classList.add("show-edit-profile");
    });
}

if (editClose) {
    editClose.addEventListener("click", () => {
        editContent.classList.remove("show-edit-profile");
    });
}

/*=============== REGISTER SELLER ===============*/
const sellerButton = document.getElementById("seller-register"),
    sellerClose = document.getElementById("register-seller-close"),
    sellerContent = document.getElementById("register-seller");

if (sellerButton) {
    sellerButton.addEventListener("click", () => {
        sellerContent.classList.add("show-register-seller");
    });
}

if (sellerClose) {
    sellerClose.addEventListener("click", () => {
        sellerContent.classList.remove("show-register-seller");
    });
}
/*=============== ADD PRODUCT ===============*/
const productImage = document.getElementById('product-image-preview');
const imgArea = document.getElementById('img-area');
productImage.addEventListener('change', function () {
    const image = this.files[0];
    const reader = new FileReader();
    reader.onload = () => {
        const imgUrl = reader.result;
        const img = document.createElement('img');
        img.src = imgUrl;
        imgArea.appendChild(img);
        imgArea.classList.remove("hidden");
    }
    reader.readAsDataURL(image);
});
