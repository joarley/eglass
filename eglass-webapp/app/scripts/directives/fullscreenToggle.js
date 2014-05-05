'use strict';

angular.module('eglass-webapp')
  .directive('fullscreenToggle', function () {
    function launchFullscreen(element) {
  		if(element.requestFullscreen) {
    		element.requestFullscreen();
  		} else if(element.mozRequestFullScreen) {
    		element.mozRequestFullScreen();
  		} else if(element.webkitRequestFullscreen) {
    		element.webkitRequestFullscreen();
  		} else if(element.msRequestFullscreen) {
    		element.msRequestFullscreen();
  		}
	}

	function exitFullscreen() {
  		if(document.exitFullscreen) {
    		document.exitFullscreen();
  		} else if(document.mozCancelFullScreen) {
    		document.mozCancelFullScreen();
  		} else if(document.webkitExitFullscreen) {
    		document.webkitExitFullscreen();
  		}	
	}

	function link(scope, element, attrs)
	{
		var target = attrs.fullscreenToggle || 'body';
		var isFullscreen = false;

		scope.$watch(attrs.fullscreenToggle, function(value){
			target = attrs.fullscreenToggle || 'body';
		});

		element.click(function() {
			if(isFullscreen)
				exitFullscreen();
			else
				launchFullscreen($(target)[0]);

			isFullscreen = !isFullscreen;
		});
	}

    return {
      template: '',
      restrict: 'A',
      link: link
    };
  });
