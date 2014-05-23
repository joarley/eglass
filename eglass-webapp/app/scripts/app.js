'use strict';

angular
<<<<<<< HEAD
  .module('eglass-webapp', ['ngRoute'])
=======
  .module('eglass-webapp', ['ngRoute', 'chieffancypants.loadingBar', 'ui.bootstrap'])
>>>>>>> ceae2ec76c164f398ac7072692c9602b3de5fb4e
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
