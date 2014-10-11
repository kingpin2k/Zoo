Zoo.AnimalController = Em.ObjectController.extend({
    daysOld: function () {
        return moment(this.get('date_of_birth')).fromNow();
    }.property('date_of_birth')
});