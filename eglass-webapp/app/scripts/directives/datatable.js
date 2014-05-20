'use strict';

angular.module('eglass-webapp')
  .directive('datatable', function () {
  return {
    // I restricted it to A only. I initially wanted to do something like
    // <datatable> <thead> ... </thead> </datatable>
    // But thead elements are only valid inside table, and <datatable> is not a table. 
    // So.. no choice to use <table datatable>
    restrict: 'A',

    link: function ($scope, $elem, attrs) {
      if(attrs.datatable) {
        $scope.$watch(attrs.datatable, function(val) {
          // Load the datatable! 
          $elem.dataTable(val);
        });
      }
    }
  };
});

