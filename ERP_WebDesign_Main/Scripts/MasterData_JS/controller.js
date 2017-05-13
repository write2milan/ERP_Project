(function () {
    'use strict';

    var controllerModule = angular.module('ERP-CONTROLLER', []);
    controllerModule.controller('codification', ['$scope', 'codificationfactory', '$window', function ($scope, codificationfactory, $window) {

        $scope.ErrorFlagValidation = false;
        $scope.IsCodePresent = false;
        $scope.DisableAllDropdown = false;
        $scope.MaxSize = 5;     // Limit number for pagination display number.  
        $scope.SearchText = "";

        $scope.AlertMsg = "";
        $scope.init = function (Codification_Model) {
            $scope.Codification_Model = Codification_Model;
        };

        $scope.BindCodificationForIndex = function (Codification_Model) {
            $scope.Codification_Model = Codification_Model.Collection;
            $scope.TotalCount = Codification_Model.ItemCount;
            $scope.PageIndex = Codification_Model.PageNo;
            $scope.PageSizeSelected = Codification_Model.PageSize;

        };


        $scope.PageChanged = function (url) {
            ERP_JS_MAIN.showPleaseWait();
            codificationfactory.GetPagedItems(url, $scope.SearchText, $scope.PageIndex).then(function (response) {
                $scope.BindCodificationForIndex(response.data);
                ERP_JS_MAIN.hidePleaseWait();
            }).catch(function (response) {
                ERP_JS_MAIN.hidePleaseWait();
                ERP_JS_MAIN.OnFailure(response);
            });

        };

        $scope.Search = function (url) {
            ERP_JS_MAIN.showPleaseWait();
            codificationfactory.GetSearchItems(url, $scope.SearchText).then(function (response) {
                $scope.BindCodificationForIndex(response.data);
                ERP_JS_MAIN.hidePleaseWait();
            }).catch(function (response) {
                ERP_JS_MAIN.hidePleaseWait();
                ERP_JS_MAIN.OnFailure(response);
            });

        };



        $scope.GetItems = function (url) {
            ERP_JS_MAIN.showPleaseWait();
            codificationfactory.GetCodiItems($scope.Codification_Model.GroupID, url).then(function (response) {
                $scope.Codification_Model.Items = response.data;
                ERP_JS_MAIN.hidePleaseWait();
            }).catch(function (response) {
                ERP_JS_MAIN.hidePleaseWait();
                ERP_JS_MAIN.OnFailure(response);
            });
        };

        $scope.GetSpecs = function (url) {
            ERP_JS_MAIN.showPleaseWait();
            codificationfactory.GetCodiSpecs($scope.Codification_Model.ItemID, url).then(function (response) {
                $scope.Codification_Model.Specifications = response.data;
                ERP_JS_MAIN.hidePleaseWait();
            }).catch(function (response) {
                ERP_JS_MAIN.hidePleaseWait();
                ERP_JS_MAIN.OnFailure(response);
            });
        };

        $scope.InsertCodi = function (url) {
            codificationfactory.InsertCodi($scope.Codification_Model, url).then(function (response) {
                ERP_JS_MAIN.OpenModalAfterSaveRecord(response.data);
            }).catch(function (response) {
                ERP_JS_MAIN.OnFailure(response);
            });
        };

        $scope.UpdateCodi = function (url) {
            codificationfactory.UpdateCodi($scope.Codification_Model, url).then(function (response) {
                ERP_JS_MAIN.OpenModalAfterSaveRecord(response.data);

            }).catch(function (response) {
                ERP_JS_MAIN.OnFailure(response);
            });
        };

        $scope.GenerateCode = function (url, itemid) {
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
                $scope.DisableAllDropdown = true;
                $scope.Codification_Model.CodificationCode = selectedGrpObject.Code + "-" + selectedItemObject.Code
                    + "-" + selectedSpecsObject.Code + "-" + selectedRacksObject.Code;
                if (itemid)
                    IsExistCodeCodi(url, $scope.Codification_Model.CodificationCode, $scope.Codification_Model.CodificationID);
                else
                    IsExistCodeCodi(url, $scope.Codification_Model.CodificationCode);
            }
        };

        var IsExistCodeCodi = function (url, code, itemid) {
            ERP_JS_MAIN.showPleaseWait();
            codificationfactory.GetIsExistCodeCodi(code, url, itemid).then(function (response) {
                $scope.IsCodePresent = !((JSON.parse(response.data)).IsExist);
                $scope.AlertMsg = (JSON.parse(response.data)).AlertMessage;
                ERP_JS_MAIN.hidePleaseWait();
            }).catch(function (response) {
                ERP_JS_MAIN.hidePleaseWait();
                ERP_JS_MAIN.OnFailure(response);
            });

        };


    }]);

    controllerModule.controller('groups', ['$scope', 'groupsfactory', '$window', function ($scope, groupsfactory, $window) {
        $scope.BtnDisable = false;
        $scope.GC = "";
        $scope.AlertMsg = "";
        $scope.IsExistCodeGroups = function (url) {
            ERP_JS_MAIN.showPleaseWait();
            groupsfactory.GetIsExistCodeGroups($scope.GC, url).then(function (response) {
                $scope.BtnDisable = (JSON.parse(response.data)).IsExist;
                $scope.AlertMsg = (JSON.parse(response.data)).AlertMessage;
                ERP_JS_MAIN.hidePleaseWait();
            }).catch(function (response) {
                ERP_JS_MAIN.hidePleaseWait();
                ERP_JS_MAIN.OnFailure(response);
            });

        };


    }]);

    controllerModule.controller('racks', ['$scope', 'racksfactory', '$window', function ($scope, racksfactory, $window) {
        $scope.BtnDisable = false;
        $scope.RC = "";
        $scope.AlertMsg = "";
        $scope.IsExistCodeRacks = function (url) {
            ERP_JS_MAIN.showPleaseWait();
            racksfactory.GetIsExistCodeRacks($scope.RC, url).then(function (response) {
                $scope.BtnDisable = (JSON.parse(response.data)).IsExist;
                $scope.AlertMsg = (JSON.parse(response.data)).AlertMessage;
                ERP_JS_MAIN.hidePleaseWait();
            }).catch(function (response) {
                ERP_JS_MAIN.hidePleaseWait();
                ERP_JS_MAIN.OnFailure(response);
            });

        };


    }]);

    controllerModule.controller('items', ['$scope', 'itemsfactory', '$window', function ($scope, itemsfactory, $window) {
        $scope.BtnDisable = false;
        $scope.IC = "";
        $scope.AlertMsg = "";
        $scope.IsExistCodeItems = function (url) {
            ERP_JS_MAIN.showPleaseWait();
            itemsfactory.GetIsExistCodeItems($scope.IC, url).then(function (response) {
                $scope.BtnDisable = (JSON.parse(response.data)).IsExist;
                $scope.AlertMsg = (JSON.parse(response.data)).AlertMessage;
                ERP_JS_MAIN.hidePleaseWait();
            }).catch(function (response) {
                ERP_JS_MAIN.hidePleaseWait();
                ERP_JS_MAIN.OnFailure(response);
            });

        };


    }]);

    controllerModule.controller('specification', ['$scope', 'specfactory', '$window', function ($scope, specfactory, $window) {
        $scope.BtnDisable = false;
        $scope.AlertMsg = "";
        $scope.Errors = {};

        $scope.init = function (SpecificationMaster_Model) {
            $scope.SpecificationMaster_Model = SpecificationMaster_Model;
        };

        $scope.InsertSpec = function (url) {
            specfactory.InsertSpec($scope.SpecificationMaster_Model, url).then(function (response) {
                if (typeof (response.data.errors) !== 'undefined' && Object.keys(response.data.errors).length > 0) {
                    $scope.Errors = response.data.errors;
                    return;
                }
                ERP_JS_MAIN.OpenModalAfterSaveRecord(response.data);
            }).catch(function (response) {
                ERP_JS_MAIN.OnFailure(response);
            });
        };

        $scope.UpdateSpec = function (url) {
            specfactory.UpdateSpec($scope.SpecificationMaster_Model, url).then(function (response) {
                if (typeof (response.data.errors) !== 'undefined' && Object.keys(response.data.errors).length > 0) {
                    $scope.Errors = response.data.errors;
                    return;
                }
                ERP_JS_MAIN.OpenModalAfterSaveRecord(response.data);

            }).catch(function (response) {
                ERP_JS_MAIN.OnFailure(response);
            });
        };

        $scope.GetItems = function (url) {
            ERP_JS_MAIN.showPleaseWait();
            specfactory.GetSpecItems($scope.SpecificationMaster_Model.GroupID, url).then(function (response) {
                $scope.SpecificationMaster_Model.Items = response.data;
                ERP_JS_MAIN.hidePleaseWait();
            }).catch(function (response) {
                ERP_JS_MAIN.hidePleaseWait();
                ERP_JS_MAIN.OnFailure(response);
            });
        };

        $scope.IsExistCodeSpec = function (url) {
            ERP_JS_MAIN.showPleaseWait();
            specfactory.GetIsExistCodeSpec($scope.SpecificationMaster_Model.SpecificationCode, url).then(function (response) {
                $scope.BtnDisable = (JSON.parse(response.data)).IsExist;
                $scope.AlertMsg = (JSON.parse(response.data)).AlertMessage;
                ERP_JS_MAIN.hidePleaseWait();
            }).catch(function (response) {
                ERP_JS_MAIN.hidePleaseWait();
                ERP_JS_MAIN.OnFailure(response);
            });

        };


    }]);
})();
