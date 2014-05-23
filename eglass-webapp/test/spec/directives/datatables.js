'use strict';

describe('Directive: datatables', function () {

  // load the directive's module
  beforeEach(module('eglassWebappApp'));

  var element,
    scope;

  beforeEach(inject(function ($rootScope) {
    scope = $rootScope.$new();
  }));

  it('should make hidden element visible', inject(function ($compile) {
    element = angular.element('<datatables></datatables>');
    element = $compile(element)(scope);
    expect(element.text()).toBe('this is the datatables directive');
  }));
});
