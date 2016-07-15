(function () {
    'use strict';

    angular
        .module('userService', ['ngResource'])
        .factory('User', User);

    User.$inject = ['$resource'];

    function User($resource) {
        return $resource('/api/users/:id', null, {
            'update': { method: 'PUT' }
        });
    }
})();

(function () {
    'use strict';

    angular
        .module('userService')
        .factory('isUsernameAvailable', isUsernameAvailable)

    isUsernameAvailable.$inject = ['$q', '$http']

    function isUsernameAvailable($q, $http) {
        return function(username) {
            var deferred = $q.defer();

            $http.get('/api/users/username/' + username).then(function successCallback() {
                deferred.reject();
            }, function errorCallback() {
                deferred.resolve();
            });

            return deferred.promise;
        }
    }
})();
