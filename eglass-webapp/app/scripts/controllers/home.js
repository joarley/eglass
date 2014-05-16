'use strict';

angular.module('eglass-webapp')
  .controller('homeCtrl', function($scope) {
    //pageSetUp();

    /*
       * BASIC
       */
      $('#dt_basic').dataTable({
        "sPaginationType" : "bootstrap_full"
      });

      /* END BASIC */
  });
