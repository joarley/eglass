'use strict';

angular.module('eglass-webapp')
  .directive('jarvisMenu', [function () {
    function link(scope, element, attrs) {
      var params;

      try {
        params = scope.$eval(attrs.jarvisMenu);        
      } catch(ex){}

      if(!angular.isObject(params))
      {
        params = {};
      }

      params = angular.extend(params,
        {
          accordion : true,
          speed : 235,
          closedSign : '<em class="fa fa-expand-o"></em>',
          openedSign : '<em class="fa fa-collapse-o"></em>'
        });

      element.children('ul').jarvismenu({
			  accordion : params.accordion || true,
			  speed : params.speed || 235,
			  closedSign : params.closedSign || '<em class="fa fa-expand-o"></em>',
			  openedSign : params.openedSign || '<em class="fa fa-collapse-o"></em>'
		  });
    }

    return {
      template: '',
      restrict: 'A',
      link: link
    };
  }]);
