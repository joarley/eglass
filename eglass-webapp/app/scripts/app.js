'use strict';

angular
  .module('eglass-webapp', ['ngRoute'])
  .config(function($routeProvider) {
    $routeProvider
      .when('/', {
        templateUrl: 'views/home.html',
        controller: 'homeCtrl'
      })
      .otherwise({
        redirectTo: '/'
      });
  });
