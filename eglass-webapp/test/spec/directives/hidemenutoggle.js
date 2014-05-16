'use strict';

describe('Directive: hideMenuToggle', function () {

  // load the directive's module
  beforeEach(module('eglassWebappApp'));

  var element,
    scope;

  beforeEach(inject(function ($rootScope) {
    scope = $rootScope.$new();
  }));

  it('should make hidden element visible', inject(function ($compile) {
    element = angular.element('<hide-menu-toggle></hide-menu-toggle>');
    element = $compile(element)(scope);
    expect(element.text()).toBe('this is the hideMenuToggle directive');
  }));
});
