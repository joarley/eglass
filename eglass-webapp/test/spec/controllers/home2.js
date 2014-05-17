'use strict';

describe('Controller: Home2Ctrl', function () {

  // load the controller's module
  beforeEach(module('eglassWebappApp'));

  var Home2Ctrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    Home2Ctrl = $controller('Home2Ctrl', {
      $scope: scope
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(scope.awesomeThings.length).toBe(3);
  });
});
