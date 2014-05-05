'use strict';

angular
  .module('eglass-webapp', ['ngRoute'])
  .config(function($routeProvider, $locationProvider) {
    $locationProvider.html5Mode(false);

    $routeProvider
      .when('/home', {
        templateUrl: 'views/home.html',
        controller: 'homeCtrl'
      })
      .otherwise({
        redirectTo: '/home'
      });
  });
