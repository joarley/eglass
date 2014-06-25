'use strict';

angular.module('eglass-webapp')
  .directive('hideMenuToggle', function () {
    function link(scope, element) {
      element.click(function() {
        angular.element('body').toggleClass('hidden-menu');
      });
    }

    return {
      template: '',
      restrict: 'A',
      link: link
    };
  });
