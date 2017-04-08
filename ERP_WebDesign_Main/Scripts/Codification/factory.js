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


})();