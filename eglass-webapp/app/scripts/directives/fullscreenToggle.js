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

<<<<<<< HEAD
	function exitFullscreen() {
  		if(document.exitFullscreen) {
    		document.exitFullscreen();
  		} else if(document.mozCancelFullScreen) {
    		document.mozCancelFullScreen();
  		} else if(document.webkitExitFullscreen) {
    		document.webkitExitFullscreen();
  		}	
	}
=======
    function exitFullscreen() {
      if($document[0].exitFullscreen) {
        $document[0].exitFullscreen();
      } else if($document[0].msExitFullscreen){
        $document[0].msExitFullscreen();
      } else if($document[0].mozCancelFullScreen) {
        $document[0].mozCancelFullScreen();
      } else if($document[0].webkitExitFullscreen) {
        $document[0].webkitExitFullscreen();
      }
    }
>>>>>>> ceae2ec76c164f398ac7072692c9602b3de5fb4e

	function link(scope, element, attrs)
	{
		var target = attrs.fullscreenToggle || 'html';
		var isFullscreen = false;

		scope.$watch(attrs.fullscreenToggle, function(value){
			target = attrs.fullscreenToggle || 'html';
		});

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
