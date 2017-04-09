(function () {
    var ERP_APP = angular.module('ERP-APP', ['ERP-CONTROLLER', 'ERP-SERVICE']);
    var controllerModule = angular.module('ERP-CONTROLLER', []);
    var serviceModule = angular.module('ERP-SERVICE', []);

})();

var OpenModalAfterSaveRecord = function (url) {
    $('#thankyouModal').modal({
        backdrop: 'static',
        keyboard: false
    }).one('click', '#ok', function (e) {
        window.location = url;
    });
};

var OnSuccess = function (result) {
    OpenModalAfterSaveRecord(result);
}

var OnFailure = function (result) {
    document.write(result.data);
}