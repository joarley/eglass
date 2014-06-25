'use strict';

angular.module('eglass-webapp')
  .directive('headerTabWidget', function () {
    function link(scope, element) {
        element.find('li a').click(function (e) {
          e.preventDefault()
          $(this).tab('show')
        });
    }

    return {
      template: '',
      restrict: 'A',
      link: link
    };
  });
