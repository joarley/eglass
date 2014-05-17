'use strict';

angular.module('eglass-webapp')
  .controller('Home2Ctrl', ['$scope','$http', function ($scope, $http) {
    $scope.awesomeThings = [
      'HTML5 Boilerplate',
      'AngularJS',
      'Karma'
    ];

    $http({method: 'GET', url: 'http://localhost:22726/Plant/getall'}).
    success(function(data, status, headers, config) {
      
    }).
    error(function(data, status, headers, config) {
      
    });
  }]);
