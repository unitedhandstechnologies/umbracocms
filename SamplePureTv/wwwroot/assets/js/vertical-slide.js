// debounce from underscore.js
function debounce(func, wait, immediate) {
	var timeout;
	return function() {
		var context = this, args = arguments;
		var later = function() {
			timeout = null;
			if (!immediate) func.apply(context, args);
		};
		var callNow = immediate && !timeout;
		clearTimeout(timeout);
		timeout = setTimeout(later, wait);
		if (callNow) func.apply(context, args);
	};
};

// use x and y mousewheel event data to navigate flickity
function slick_handle_wheel_event(e, slick_instance, slick_is_animating) {
  // do not trigger a slide change if another is being animated
  if (!slick_is_animating) {
    // pick the larger of the two delta magnitudes (x or y) to determine nav direction
    var direction =
      Math.abs(e.deltaX) > Math.abs(e.deltaY) ? e.deltaX : e.deltaY;

    console.log("wheel scroll ", e.deltaX, e.deltaY, direction);

    if (direction > 0) {
      // next slide
      slick_instance.slick("slickNext");
    } else {
      // prev slide
      slick_instance.slick("slickPrev");
    }
  }
}

// debounce the wheel event handling since trackpads can have a lot of inertia
var slick_handle_wheel_event_debounced = debounce( 
  slick_handle_wheel_event
  , 100, true
);

// init slider 
const slick_2 = $(".slides");
slick_2.slick({
  dots: true,
  vertical: true,
  // verticalSwiping: true,
  arrows: false
});
var slick_2_is_animating = false;

slick_2.on("afterChange", function(index) {
  console.log("Slide after change " + index);
  slick_2_is_animating = false;
});

slick_2.on("beforeChange", function(index) {
  console.log("Slide before change " + index);
  slick_2_is_animating = true;
});

slick_2.on("wheel", function(e) {
  slick_handle_wheel_event_debounced(e.originalEvent, slick_2, slick_2_is_animating);  
});