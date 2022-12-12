$(document).ready(function(){
  $('.container-img-navbar').slick({
    autoplay: true,// tự động chuyển ảnh
    autoplaySpeed: 6000,// thời gian chuyển ảnh
    // slidesToShow: 3,//Số ảnh hiển thị trên slide
    // slideToScroll:2,//Số ảnh di chuyển mỗi lượt scroll
    // infinite: true, //Lặp vô tận
    prevArrow:"<button type='button' class='slick-prev pull-left'><i class='fa fa-angle-left' aria-hidden='true'></i></button>",
    nextArrow:"<button type='button' class='slick-next pull-right'><i class='fa fa-angle-right' aria-hidden='true'></i></button>",
    
  });
})

$(document).ready(function(){
  $('.intro-products').slick({
    autoplay: true,// tự động chuyển ảnh
    autoplaySpeed: 6000,// thời gian chuyển ảnh
    slidesToShow: 5,//Số ảnh hiển thị trên slide
    slidesToScroll: 2,//Số ảnh di chuyển mỗi lượt scroll
    infinite: true, //Lặp vô tận
    prevArrow:"<button type='button' class='slick-prev pull-left'><i class='fa fa-angle-left' aria-hidden='true'></i></button>",
    nextArrow:"<button type='button' class='slick-next pull-right'><i class='fa fa-angle-right' aria-hidden='true'></i></button>",
  });
})