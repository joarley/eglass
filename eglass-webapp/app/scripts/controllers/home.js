'use strict';

angular.module('eglass-webapp')
  .controller('homeCtrl', function($scope) {
<<<<<<< HEAD
    pageSetUp();

    /*
       * BASIC
       */
      $('#dt_basic').dataTable({
        "sPaginationType" : "bootstrap_full"
      });

      /* END BASIC */
=======
    $scope.tableOptions = {'sPaginationType' : 'bootstrap_full'};

    
>>>>>>> ceae2ec76c164f398ac7072692c9602b3de5fb4e
  });
