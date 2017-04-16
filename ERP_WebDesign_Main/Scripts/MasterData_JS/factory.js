(function () {
    'use strict';

    var serviceModule = angular.module('ERP-SERVICE', []);
    serviceModule.factory('codificationfactory', ['$http', function ($http) {
        var get_Items = function (grpId) {
            return $http({
                method: 'POST',
                url: '/MasterData/PopulateCodiItems',
                data: JSON.stringify({ grpId: grpId })
            });
        };

        var get_Specs = function (itemId) {
            return $http({
                method: 'POST',
                url: '/MasterData/PopulateCodiSpecs',
                data: JSON.stringify({ itemId: itemId })
            });
        };

        var insert_Codi = function (objModel) {
            return $http({
                method: 'POST',
                url: '/MasterData/CodificationMaster_Create',
                data: JSON.stringify({ objModel: objModel })
            });
        };

        var update_Codi = function (objModel) {
            return $http({
                method: 'POST',
                url: '/MasterData/CodificationMaster_Edit',
                data: JSON.stringify({ Entity: objModel })
            });
        };

        return {
            GetCodiItems: get_Items,
            GetCodiSpecs: get_Specs,
            InsertCodi: insert_Codi,
            UpdateCodi: update_Codi
        }

    }]);

    serviceModule.factory('groupsfactory', ['$http', function ($http) {
        var get_IsExistCodeGroups = function (code) {
            return $http({
                method: 'POST',
                url: '/MasterData/IsExistCodeGroups',
                data: JSON.stringify({ code: code })
            });
        };


        return {
            GetIsExistCodeGroups: get_IsExistCodeGroups
        }

    }]);

    serviceModule.factory('racksfactory', ['$http', function ($http) {
        var get_IsExistCodeRacks = function (code) {
            return $http({
                method: 'POST',
                url: '/MasterData/IsExistCodeRacks',
                data: JSON.stringify({ code: code })
            });
        };


        return {
            GetIsExistCodeRacks: get_IsExistCodeRacks
        }

    }]);

    serviceModule.factory('itemsfactory', ['$http', function ($http) {
        var get_IsExistCodeItems = function (code) {
            return $http({
                method: 'POST',
                url: '/MasterData/IsExistCodeItems',
                data: JSON.stringify({ code: code })
            });
        };


        return {
            GetIsExistCodeItems: get_IsExistCodeItems
        }

    }]);

    serviceModule.factory('specfactory', ['$http', function ($http) {
        var get_IsExistCodeSpec = function (code) {
            return $http({
                method: 'POST',
                url: '/MasterData/IsExistSpecItems',
                data: JSON.stringify({ code: code })
            });
        };

        var get_Items = function (grpId) {
            return $http({
                method: 'POST',
                url: '/MasterData/PopulateSpecItems',
                data: JSON.stringify({ grpId: grpId })
            });
        };

        var insert_Spec = function (objModel) {
            return $http({
                method: 'POST',
                url: '/MasterData/SpecificationMaster_Create',
                data: JSON.stringify({ objModel: objModel })
            });
        };

        var update_Spec = function (objModel) {
            return $http({
                method: 'POST',
                url: '/MasterData/SpecificationMaster_Edit',
                data: JSON.stringify({ Entity: objModel })
            });
        };


        return {
            GetIsExistCodeSpec: get_IsExistCodeSpec,
            GetSpecItems: get_Items,
            InsertSpec: insert_Spec,
            UpdateSpec: update_Spec
        }

    }]);

})();