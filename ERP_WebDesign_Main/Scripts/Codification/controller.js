(function () {
    'use strict';

    var controllerModule = angular.module('ERP-CONTROLLER', []);
    controllerModule.controller('codification', ['$scope', 'codificationfactory', '$window', function ($scope, codificationfactory, $window) {
        $scope.ErrorMessageValidation = "Please select all the dropdown fields.";
        $scope.ErrorFlagValidation = false;
        $scope.IsCodePresent = false;
        $scope.DisableAllDropdown = false;
        $scope.init = function (Codification_Model) {
            $scope.Codification_Model = Codification_Model;
        };

        $scope.GetItems = function () {
            codificationfactory.GetCodiItems($scope.Codification_Model.GroupID).then(function (response) {
                $scope.Codification_Model.Items = response.data;
            });
        };

        $scope.GetSpecs = function () {
            codificationfactory.GetCodiSpecs($scope.Codification_Model.ItemID).then(function (response) {
                $scope.Codification_Model.Specifications = response.data;
            });
        };

        $scope.InsertCodi = function () {
            codificationfactory.InsertCodi($scope.Codification_Model).then(function (response) {
                $window.location = "/MasterData/CodificationMaster_Index";
            });
        };

        $scope.UpdateCodi = function () {
            codificationfactory.UpdateCodi($scope.Codification_Model).then(function (response) {
                $window.location = "/MasterData/CodificationMaster_Index";
            });
        };

        $scope.GenerateCode = function () {
            var selectedGrpObject = _.find($scope.Codification_Model.Groups, function (o) { return o.Value === $scope.Codification_Model.GroupID; });
            var selectedItemObject = _.find($scope.Codification_Model.Items, function (o) { return o.Value === $scope.Codification_Model.ItemID; });
            var selectedSpecsObject = _.find($scope.Codification_Model.Specifications, function (o) { return o.Value === $scope.Codification_Model.SpecificationID; });
            var selectedRacksObject = _.find($scope.Codification_Model.Racks, function (o) { return o.Value === $scope.Codification_Model.RackID; });

            if ((typeof selectedGrpObject === 'undefined' || selectedGrpObject.Code === "")
                || (typeof selectedItemObject === 'undefined' || selectedItemObject.Code === "")
                || (typeof selectedSpecsObject === 'undefined' || selectedSpecsObject.Code === "")
                || (typeof selectedRacksObject === 'undefined' || selectedRacksObject.Code === "")) {
                $scope.ErrorFlagValidation = true;
                $scope.IsCodePresent = false;
                $scope.DisableAllDropdown = false;
            } else {
                $scope.ErrorFlagValidation = false;
                $scope.IsCodePresent = true;
                $scope.DisableAllDropdown = true;
                $scope.Codification_Model.CodificationCode = selectedGrpObject.Code + "-" + selectedItemObject.Code
                    + "-" + selectedSpecsObject.Code + "-" + selectedRacksObject.Code;
            }
        };


    }]);


})();
