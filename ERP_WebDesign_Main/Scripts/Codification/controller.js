(function () {
    'use strict';

    var controllerModule = angular.module('ERP-CONTROLLER', []);
    controllerModule.controller('codification', ['$scope', function ($scope) {
        $scope.init = function (Codification_Model) {
            $scope.Codification_Model = Codification_Model;
        }


    }]);


})();
