'use strict';

describe('Directive: jarvisMenu', function () {

  // load the directive's module
  beforeEach(module('eglassWebappApp'));

  var element,
    scope;

  beforeEach(inject(function ($rootScope) {
    scope = $rootScope.$new();
  }));

  it('should make hidden element visible', inject(function ($compile) {
    element = angular.element('<jarvis-menu></jarvis-menu>');
    element = $compile(element)(scope);
    expect(element.text()).toBe('this is the jarvisMenu directive');
  }));
});
