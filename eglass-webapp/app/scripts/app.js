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
