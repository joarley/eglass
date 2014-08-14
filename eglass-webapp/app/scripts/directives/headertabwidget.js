'use strict';

angular.module('eglass-webapp')
  .directive('headerTabWidget', function () {
    function link(scope, element) {
        element.find('li a').click(function (e) {
          e.preventDefault();
          /* jshint ignore:start */
          $(this).tab('show');
          /* jshint ignore:end */
        });
      }

    return {
      template: '',
      restrict: 'A',
      link: link
    };
  });