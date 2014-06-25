'use strict';

angular.module('eglass-webapp')
  .directive('fullscreenToggle', function ($document) {
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

    function link(scope, element, attrs) {
      var target = attrs.fullscreenToggle || 'html';
      var isFullscreen = false;

      element.click(function() {
        if(isFullscreen) {
          angular.element('body').removeClass('full-screen');
          exitFullscreen();
        }
        else {
          angular.element('body').addClass('full-screen');
          launchFullscreen(angular.element(target)[0]);
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
