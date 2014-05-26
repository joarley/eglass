'use strict';

describe('Directive: headerTabWidget', function () {

  // load the directive's module
  beforeEach(module('eglassWebappApp'));

  var element,
    scope;

  beforeEach(inject(function ($rootScope) {
    scope = $rootScope.$new();
  }));

  it('should make hidden element visible', inject(function ($compile) {
    element = angular.element('<header-tab-widget></header-tab-widget>');
    element = $compile(element)(scope);
    expect(element.text()).toBe('this is the headerTabWidget directive');
  }));
});
