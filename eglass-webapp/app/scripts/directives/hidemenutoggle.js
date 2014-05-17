'use strict';

angular.module('eglass-webapp')
  .directive('hideMenuToggle', function () {
    
    function link(scope, element, attrs)
    {
    	element.click(function() {
    		$('body').toggleClass("hidden-menu");
		});
    }

    return {
      template: '',
      restrict: 'A',
      link: link
    };
  });
