'use strict';

angular.module('eglass-webapp')
  .directive('minifymeMenuToggle', function () {
    function link(scope, element) {
      element.click(function() {
        angular.element('body').toggleClass('minified');
        angular.element(this).effect('highlight', {}, 500);
      });
    }

    return {
      template: '',
      restrict: 'A',
      link: link
    };
  });
