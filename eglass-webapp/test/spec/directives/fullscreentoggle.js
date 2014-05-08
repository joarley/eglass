'use strict';

describe('Directive: fullscreenToggle', function () {

  // load the directive's module
  beforeEach(module('eglassWebappApp'));

  var element,
    scope;

  beforeEach(inject(function ($rootScope) {
    scope = $rootScope.$new();
  }));

  it('should make hidden element visible', inject(function ($compile) {
    element = angular.element('<fullscreen-toggle></fullscreen-toggle>');
    element = $compile(element)(scope);
    expect(element.text()).toBe('this is the fullscreenToggle directive');
  }));
});
