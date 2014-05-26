'use strict';

angular.module('eglass-webapp')
  .directive('headerTabWidget', function () {
    return {
      template: '',
      restrict: 'A',
      link: function postLink(scope, element, attrs) {
        element.children('a').click(function (e) {
          e.preventDefault()
          $(this).tab('show')
        });
      }
    };
  });
