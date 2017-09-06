(function () {
    'use strict';

    var serviceModule = angular.module('ERP-SERVICE', []);
    serviceModule.factory('codificationfactory', ['$http', function ($http) {
        var get_Items = function (grpId, url) {
            return $http({
                method: 'POST',
                url: url,
                data: JSON.stringify({ grpId: grpId })
            });
        };

        var get_Specs = function (itemId, url) {
            return $http({
                method: 'POST',
                url: url,
                data: JSON.stringify({ itemId: itemId })
            });
        };

        var insert_Codi = function (objModel, url) {
            return $http({
                method: 'POST',
                url: url,
                data: JSON.stringify({ objModel: objModel })
            });
        };

        var update_Codi = function (objModel, url) {
            return $http({
                method: 'POST',
                url: url,
                data: JSON.stringify({ Entity: objModel })
            });
        };

        var get_SearchItems = function (url, searchText, ItemID, GroupID, SpecificationID, RackID) {
            return $http({
                method: 'POST',
                url: url,
                data: JSON.stringify({ searchText: searchText, ITEMID: ItemID, GROUPID: GroupID, SPECIFICATIONID: SpecificationID, RACKID: RackID })
            });
        };

        var get_PagedItems = function (url, searchText, pageNo, ItemID, GroupID, SpecificationID, RackID) {
            return $http({
                method: 'POST',
                url: url,
                data: JSON.stringify({ searchText: searchText, pageNo: pageNo, ITEMID: ItemID, GROUPID: GroupID, SPECIFICATIONID: SpecificationID, RACKID: RackID })
            });
        };

        var get_IsExistCodeCodi = function (code, url, itemid) {
            return $http({
                method: 'POST',
                url: url,
                data: JSON.stringify({ code: code, itemid: itemid })
            });
        };

        return {
            GetCodiItems: get_Items,
            GetCodiSpecs: get_Specs,
            InsertCodi: insert_Codi,
            UpdateCodi: update_Codi,
            GetSearchItems: get_SearchItems,
            GetPagedItems: get_PagedItems,
            GetIsExistCodeCodi: get_IsExistCodeCodi
        }

    }]);

    serviceModule.factory('groupsfactory', ['$http', function ($http) {
        var get_IsExistCodeGroups = function (code, url) {
            return $http({
                method: 'POST',
                url: url,
                data: JSON.stringify({ code: code })
            });
        };


        return {
            GetIsExistCodeGroups: get_IsExistCodeGroups
        }

    }]);

    serviceModule.factory('racksfactory', ['$http', function ($http) {
        var get_IsExistCodeRacks = function (code, url) {
            return $http({
                method: 'POST',
                url: url,
                data: JSON.stringify({ code: code })
            });
        };


        return {
            GetIsExistCodeRacks: get_IsExistCodeRacks
        }

    }]);

    serviceModule.factory('itemsfactory', ['$http', function ($http) {
        var get_IsExistCodeItems = function (code, url) {
            return $http({
                method: 'POST',
                url: url,
                data: JSON.stringify({ code: code })
            });
        };


        return {
            GetIsExistCodeItems: get_IsExistCodeItems
        }

    }]);

    serviceModule.factory('specfactory', ['$http', function ($http) {
        var get_IsExistCodeSpec = function (code, url) {
            return $http({
                method: 'POST',
                url: url,
                data: JSON.stringify({ code: code })
            });
        };

        var get_Items = function (grpId, url) {
            return $http({
                method: 'POST',
                url: url,
                data: JSON.stringify({ grpId: grpId })
            });
        };

        var insert_Spec = function (objModel, url) {
            return $http({
                method: 'POST',
                url: url,
                data: JSON.stringify({ objModel: objModel })
            });
        };

        var update_Spec = function (objModel, url) {
            return $http({
                method: 'POST',
                url: url,
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
