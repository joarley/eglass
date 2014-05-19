'use strict';

angular.module('eglass-webapp')
  .controller('homeCtrl', function($scope) {
    $scope.nothing = undefined;

    angular.element('#dt_basic').dataTable({'sPaginationType' : 'bs_full'});
  });
