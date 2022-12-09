 
$(document).ready(function () {

  $('.Home_offer_slider').slick({
    speed: 1500,
    slidesToShow: 1,
    slidesToScroll: 1,
    autoplay: true,
    autoplaySpeed: 2000,
    arrows: true,
    dots: false,
    nextArrow: '<div class="slick-custom-arrow2 slick-custom-arrow-right"><i class="fa fa-angle-right"></i></div>',
    prevArrow: '<div class="slick-custom-arrow2 slick-custom-arrow-left"><i class="fa fa-angle-left"></i></div>',
  });
  

});





$(document).ready(function () {
  $('.revealed_carousel').slick({
    speed: 1000,
    slidesToShow: 5,
    slidesToScroll: 1,
    autoplay: true,
    autoplaySpeed: 2000,
    arrows: false,
    dots: false,
    nextArrow: '<div class="slick-custom-arrow4 slick-custom-arrow-right"><i class="fa fa-angle-right"></i></div>',
    prevArrow: '<div class="slick-custom-arrow4 slick-custom-arrow-left"><i class="fa fa-angle-left"></i></div>',
    // centerMode: true,
    responsive: [{
      breakpoint: 1024,
      settings: {
        slidesToShow: 4,
        slidesToScroll: 1,

      }

    }, {
      breakpoint: 768,
      settings: {
        slidesToShow: 2,
        slidesToScroll: 2,
        arrows: false,
        dots: false,
        infinite: true,

      }
    }, {
      breakpoint: 600,
      settings: {
        slidesToShow: 2,
        slidesToScroll: 1,
        centerMode: false,
        arrows: false,
        dots: false,
        infinite: true,
        initialSlide: 0.8,
        slidesToScroll: 1,
        slidesToShow: 1.2,
        autoplaySpeed: 2000,
      }
    }]
  });

});






// Travel Trade Carousel

$(document).ready(function () {
  $('.travel_trade').slick({
    speed: 1000,
    slidesToShow: 4,
    slidesToScroll: 1,
    autoplay: true,
    autoplaySpeed: 2000,
    initialSlide: 0.8,
    slidesToScroll: 1,
    slidesToShow: 4.2,
    arrows: true,
    dots: false,
    infinite: true,
    nextArrow: '<div class="slick-custom-arrow_05 slick-custom-arrow-right"><i class="fa fa-angle-right"></i></div>',
    prevArrow: '<div class="slick-custom-arrow_05 slick-custom-arrow-left"><i class="fa fa-angle-left"></i></div>',
    // centerMode: true,

    
    responsive: [{
      breakpoint: 1024,
      settings: {
        slidesToShow: 2,
        slidesToScroll: 1,
      }

    }, {
      breakpoint: 768,
      settings: {
        slidesToShow: 2,
        slidesToScroll: 2,
      }
    }, {
      breakpoint: 600,
      settings: {
        slidesToShow: 2,
        slidesToScroll: 1,

        initialSlide: 0.9,
        slidesToScroll: 1,
        slidesToShow: 1.1,
        autoplaySpeed: 2000,
      }
    }]
  });

});




 

//  Home Bucket list
$(document).ready(function () {
  $('.Bucket_list').slick({
    speed: 500,
    slidesToShow: 3,
    slidesToScroll: 1,
    autoplay: false,
    autoplaySpeed: 2000,
    arrows: true,
    infinite: true,
    initialSlide: 0.5,
    slidesToScroll: 1,
    slidesToShow: 3.5,
    dots: false,
    nextArrow: '<div class="slick-custom-arrow3 slick-custom-arrow-right"><i class="fa fa-angle-right"></i></div>',
    prevArrow: '<div class="slick-custom-arrow3 slick-custom-arrow-left"><i class="fa fa-angle-left"></i></div>',
    // centerMode: true,
    responsive: [{
      breakpoint: 1024,
      settings: {
        slidesToShow: 3,
        slidesToScroll: 1,

      }

    }, {
      breakpoint: 600,
      settings: {
        slidesToShow: 2,
        slidesToScroll: 1,
        centerMode: false,
        arrows: false,
        infinite: true,
        initialSlide: 0.8,
        slidesToScroll: 1,
        slidesToShow: 1.2,
        autoplaySpeed: 2000,
      }
    }]
  });

});





  

//  Taste_Adventure 
$(document).ready(function () {
  $('.Adventure_slider').slick({
    speed: 500,
    slidesToShow: 3,
    slidesToScroll: 1,
    autoplay: false,
    autoplaySpeed: 2000,
    arrows: true,
    infinite: true,
    initialSlide: 0.5,
    slidesToScroll: 1,
    slidesToShow: 3.5,
    dots: false,
    nextArrow: '<div class="slick-custom-arrow4 slick-custom-arrow-right"><i class="fa fa-angle-right"></i></div>',
    prevArrow: '<div class="slick-custom-arrow4 slick-custom-arrow-left"><i class="fa fa-angle-left"></i></div>',
    // centerMode: true,
    responsive: [{
      breakpoint: 1024,
      settings: {
        slidesToShow: 3,
        slidesToScroll: 1,

      }

    }, {
      breakpoint: 600,
      settings: {
        slidesToShow: 2,
        slidesToScroll: 1,
        centerMode: false,
        arrows: false,
        infinite: true,
        initialSlide: 0.8,
        slidesToScroll: 1,
        slidesToShow: 1.2,
        autoplaySpeed: 2000,
      }
    }]
  });

});







//  Taste_Adventure 
$(document).ready(function () {
  $('.new_slider').slick({
    speed: 500,
    slidesToShow: 3,
    slidesToScroll: 1,
    autoplay: false,
    autoplaySpeed: 2000,
    arrows: true,
    infinite: true,
    initialSlide: 0.5,
    slidesToScroll: 1,
    slidesToShow: 3.5,
    dots: false,
    nextArrow: '<div class="slick-custom-arrow05 slick-custom-arrow-right"><i class="fa fa-angle-right"></i></div>',
    prevArrow: '<div class="slick-custom-arrow05 slick-custom-arrow-left"><i class="fa fa-angle-left"></i></div>',
    // centerMode: true,
    responsive: [{
      breakpoint: 1024,
      settings: {
        slidesToShow: 3,
        slidesToScroll: 1,

      }

    }, {
      breakpoint: 600,
      settings: {
        slidesToShow: 2,
        slidesToScroll: 1,
        centerMode: false,
        arrows: false,
        infinite: true,
        initialSlide: 0.8,
        slidesToScroll: 1,
        slidesToShow: 1.2,
        autoplaySpeed: 2000,
      }
    }]
  });

});








// Airline Partners 

$(document).ready(function () {
  $('.airline_partners').slick({
    speed: 1000,
    slidesToShow: 4,
    slidesToScroll: 1,
    autoplay: true,
    autoplaySpeed: 2000,
    arrows: false,
    dots: false,
    nextArrow: '<div class="slick-custom-arrow7 slick-custom-arrow-right"><i class="fa fa-angle-right"></i></div>',
    prevArrow: '<div class="slick-custom-arrow7 slick-custom-arrow-left"><i class="fa fa-angle-left"></i></div>',
    // centerMode: true,
    responsive: [{
      breakpoint: 1024,
      settings: {
        slidesToShow: 4,
        slidesToScroll: 1,

      }

    }, {
      breakpoint: 800,
      settings: {
        slidesToShow: 2,
        slidesToScroll: 2,
        arrows: false,
        dots: false,
        infinite: true,

      }
    }, {
      breakpoint: 600,
      settings: {
        slidesToShow: 3,
        slidesToScroll: 1,
        centerMode: false,
        arrows: false,
        dots: false,
        infinite: true,

        initialSlide: 0.8,
        slidesToScroll: 1,
        slidesToShow: 2.2,

        autoplaySpeed: 2000,
      }
    }]
  });

});


 

//  Deals_slide
$(document).ready(function () {
  $('.deals_slide').slick({
    speed: 500,
    slidesToShow: 4,
    slidesToScroll: 1,
    autoplay: false,
    autoplaySpeed: 2000,
    arrows: true,
    infinite: true,
    dots: false,
    nextArrow: '<div class="slick-custom-arrow_03 slick-custom-arrow-right"><i class="fa fa-angle-right"></i></div>',
    prevArrow: '<div class="slick-custom-arrow_03 slick-custom-arrow-left"><i class="fa fa-angle-left"></i></div>',
    // centerMode: true,
    responsive: [{
      breakpoint: 1024,
      settings: {
        slidesToShow: 3,
        slidesToScroll: 1,

      }

    }, {
      breakpoint: 600,
      settings: {
        slidesToShow: 2,
        slidesToScroll: 1,
        centerMode: false,
        arrows: false,
        infinite: true,
        initialSlide: 0.8,
        slidesToScroll: 1,
        slidesToShow: 1.2,
        autoplaySpeed: 2000,
      }
    }]
  });

});




//  All in One
$(document).ready(function () {
  $('.carousel_slide').slick({
    speed: 500,
    slidesToShow: 3,
    slidesToScroll: 1,
    autoplay: false,
    autoplaySpeed: 2000,
    arrows: true,
    infinite: true,
    initialSlide: 0.5,
    slidesToScroll: 1,
    slidesToShow: 3.5,
    dots: false,
    nextArrow: '<div class="slick-custom-arrow_01 slick-custom-arrow-right"><i class="fa fa-angle-right"></i></div>',
    prevArrow: '<div class="slick-custom-arrow_01 slick-custom-arrow-left"><i class="fa fa-angle-left"></i></div>',
    // centerMode: true,
    responsive: [{
      breakpoint: 1024,
      settings: {
        slidesToShow: 3,
        slidesToScroll: 1,

      }

    }, {
      breakpoint: 600,
      settings: {
        slidesToShow: 2,
        slidesToScroll: 1,
        centerMode: false,
        arrows: false,
        infinite: true,
        initialSlide: 0.8,
        slidesToScroll: 1,
        slidesToShow: 1.2,
        autoplaySpeed: 2000,
      }
    }]
  });

});









// ///// Page Progress Bar  

$(document).scroll(function (e) {
    var scrollAmount = $(window).scrollTop();
    var documentHeight = $(document).height();
    var windowHeight = $(window).height();
    var scrollPercent = (scrollAmount / (documentHeight - windowHeight)) * 100;
    
    // if (scrollPercent < 23){
    //   var number = 1;
    // } else if ( scrollPercent < 48) {
    //   var number = 2;
    // } else if ( scrollPercent < 73) {
    //   var number = 3;
    // } else if ( scrollPercent < 97) {
    //   var number = 4;
    // } else {
    //   var number = 5;
    // }
    
    // For scrollbar 
    $(".scrollball").css("top", "calc(" + scrollPercent + "% - 5px)");
    $(".scrollball span").text(number);
  });





//  Map Dropdown filter 

  $(document).ready(function() {
		$('.box').hide(); //hide
		$('.Active-Adventure').show(); //set default class to be shown here, or remove to hide all
});
$('select').change(function() { //on change do stuff
		$('.box').hide(); //hide all with .box class
		$('.' + $(this).val()).show(); //show selected option's respective element
});







 