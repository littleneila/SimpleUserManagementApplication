(function () {
    'use strict';

    angular
        .module('userApp')
        .controller('UserListController', UserListController)
        .controller('UserAddController', UserAddController)
        .controller('UserEditController', UserEditController)
        .controller('UserDeleteController', UserDeleteController);

    /* User List Controller  */
    UserListController.$inject = ['User'];

    function UserListController(User) {
        var vm = this;
        vm.users = User.query();
    }

    /* User Create Controller */
    UserAddController.$inject = ['$location', 'User'];

    function UserAddController($location, User) {
        var vm = this;
        vm.emailPattern = /^([a-zA-Z0-9])+([a-zA-Z0-9._%+-])+@([a-zA-Z0-9_.-])+\.(([a-zA-Z]){2,6})$/;
        vm.passwordPattern = /(?=.*[A-Z])(?=.*\d)[A-Za-z\d$@$!%*?&]{8,}$/;
        vm.user = new User();
        vm.add = add;

        function add() {
            vm.user.$save(function () {
                    $location.path('/');
                }
            );
        };
    }

    /* User Edit Controller */
    UserEditController.$inject = ['$routeParams', '$location', 'User', '$http', '$filter'];

    function UserEditController($routeParams, $location, User, $http, $filter) {
        var vm = this;
        vm.emailPattern = /^([a-zA-Z0-9])+([a-zA-Z0-9._%+-])+@([a-zA-Z0-9_.-])+\.(([a-zA-Z]){2,6})$/;
        vm.passwordPattern = /(?=.*[A-Z])(?=.*\d)[A-Za-z\d$@$!%*?&]{8,}$/;
        vm.user = User.get({ id: $routeParams.id });
        vm.edit = edit;

        function edit() {
            vm.user.$update({ id: vm.user.UserId }, function () {
                    $location.path('/');
                }
            );
        };
    }

    /* User Delete Controller  */
    UserDeleteController.$inject = ['$routeParams', '$location', 'User'];

    function UserDeleteController($routeParams, $location, User) {
        var vm = this;
        vm.user = User.get({ id: $routeParams.id });
        vm.remove = remove;

        function remove() {
            vm.user.$remove({ id: vm.user.UserId }, function () {
                $location.path('/');
            });
        };
    }

})();