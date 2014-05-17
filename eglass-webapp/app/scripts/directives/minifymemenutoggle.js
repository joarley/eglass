'use strict';

angular.module('eglass-webapp')
  .directive('minifymeMenuToggle', function () {
    function link(scope, element, attrs)
    {
    	element.click(function() {
    		$('body').toggleClass("minified");
			$(this).effect("highlight", {}, 500);
		});
    }

    return {
      template: '',
      restrict: 'A',
      link: link
    };
  });
