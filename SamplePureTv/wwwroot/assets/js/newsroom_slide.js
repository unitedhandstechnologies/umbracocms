 

 
let Buttons = document.querySelectorAll(".selectSection button");
for (let button of Buttons) {
  button.addEventListener('click', (e) => {
    const et = e.target;
    const active = document.querySelector(".active");

    if (active) {
      active.classList.remove("active");
    }

    et.classList.add("active");
  
    let allContent = document.querySelectorAll('.content');


    for (let content of allContent) {
      if(content.getAttribute('data-number') === button.getAttribute('data-number')) {
        content.style.display = "block";
       }
 
      else {
        content.style.display = "none";
       }
     }
  });
}



 
// Newsroom
 
 
$('.slider-for').slick({
  slidesToShow: 1,
  slidesToScroll: 1,
  arrows: false,
  fade: true,
  adaptiveHeight: true,
  asNavFor: '.slider-nav'
});
$('.slider-nav').slick({
  slidesToShow: 1,
  slidesToScroll: 1,
  // infinite : false,  

  asNavFor: '.slider-for',
  // fade: true,
  dots: false,
  nextArrow: '<div class="slick-custom-arrow-10 slick-custom-arrow-right"><i class="fa fa-angle-right"></i></div>',
  prevArrow: '<div class="slick-custom-arrow-10 slick-custom-arrow-left"><i class="fa fa-angle-left"></i></div>',
});






// Testimonials




 
$(document).ready(function () {
  $('.testimonials_slider').slick({
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1,
    autoplay: false,
    autoplaySpeed: 2000,
    arrows: true,
    infinite: true,

    // initialSlide: 0.5,
    // slidesToScroll: 1,
    // slidesToShow: 1.5,
    dots: false,
    nextArrow: '<div class="slick-custom-arrow-20 slick-custom-arrow-right"><i class="fa fa-angle-right"></i></div>',
    prevArrow: '<div class="slick-custom-arrow-20 slick-custom-arrow-left"><i class="fa fa-angle-left"></i></div>',
    // centerMode: true,
    responsive: [{
      breakpoint: 1024,
      settings: {
        slidesToShow: 1,
        slidesToScroll: 1,

      }

    }, {
      breakpoint: 600,
      settings: {
        slidesToShow: 1,
        slidesToScroll: 1,
        centerMode: false,
        arrows: false,
        infinite: true,
        // initialSlide: 0.8,
        // slidesToScroll: 1,
        // slidesToShow: 1.2,
        autoplaySpeed: 2000,
      }
    }]
  });

});
