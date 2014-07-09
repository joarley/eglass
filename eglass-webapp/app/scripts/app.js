'use strict';

angular
  .module('eglass-webapp', ['ngRoute', 'chieffancypants.loadingBar', 'ui.bootstrap'])
  .config(function($routeProvider, $locationProvider) {
    $locationProvider.html5Mode(false);

    $routeProvider
      .when('/home', {
        templateUrl: 'views/home.html',
        controller: 'homeCtrl'
      })
      .when('/home2', {
        templateUrl: 'views/home2.html',
        controller: 'Home2Ctrl'
      })
      .otherwise({
        redirectTo: '/home'
      });
  });


/*
* NAV OR #LEFT-BAR RESIZE DETECT
* Description: changes the page min-width of #CONTENT and NAV when navigation is resized.
* This is to counter bugs for min page width on many desktop and mobile devices.
* Note: This script uses JSthrottle technique so don't worry about memory/CPU usage
*/

// Fix page and nav height
function nav_page_height() {
  var setHeight = $('#main').height();
  //menuHeight = $.left_panel.height();
  
  var windowHeight = $(window).height() - 49;
  //set height

  if (setHeight > windowHeight) {// if content height exceedes actual window height and menuHeight
    $('#left-panel').css('min-height', setHeight + 'px');
    $('body').css('min-height', setHeight + $.navbar_height + 'px');

  } else {
    $('#left-panel').css('min-height', windowHeight + 'px');
    $('body').css('min-height', windowHeight + 'px');
  }
}

$(document).ready(function(){
$('#main').resize(function() {
  nav_page_height();
  check_if_mobile_width();
})

$('nav').resize(function() {
  nav_page_height();
})

function check_if_mobile_width() {
  if ($(window).width() < 979) {
    $.root_.addClass('mobile-view-activated')
  } else if ($.root_.hasClass('mobile-view-activated')) {
    $.root_.removeClass('mobile-view-activated');
  }
}
});

/* ~ END: NAV OR #LEFT-BAR RESIZE DETECT */