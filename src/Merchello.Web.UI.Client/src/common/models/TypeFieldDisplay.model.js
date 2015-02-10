    /**
     * @ngdoc model
     * @name Merchello.Models.TypeField
     * @function
     *
     * @description
     * Represents a JS version of Merchello's TypeFieldDisplay object
     */
    var TypeFieldDisplay = function() {
        var self = this;
        self.alias = 'test';
        self.name = 'test';
        self.typeKey = '';
    };

    angular.module('merchello.models').constant('TypeFieldDisplay', TypeFieldDisplay);
