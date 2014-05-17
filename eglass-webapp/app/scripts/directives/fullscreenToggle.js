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
      } else if(document.msExitFullscreen){
        document.msExitFullscreen();
      } else if(document.mozCancelFullScreen) {
    		document.mozCancelFullScreen();
  		} else if(document.webkitExitFullscreen) {
    		document.webkitExitFullscreen();
  		}	
	}

	function link(scope, element, attrs)
	{
		var target = attrs.fullscreenToggle || 'html';
		var isFullscreen = false;

		element.click(function() {
			if(isFullscreen){
				$('body').removeClass('full-screen');
				exitFullscreen();
			}
			else{
				$('body').addClass('full-screen')
				launchFullscreen($(target)[0]);
			}

			isFullscreen = !isFullscreen;
		});
	}

    return {
      template: '',
      restrict: 'A',
      link: link
    };
  });
