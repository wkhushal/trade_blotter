var gulp = require('gulp');
var sourcemaps = require('gulp-sourcemaps');
var concat = require('gulp-concat');
var ts = require('gulp-typescript');
var systemjsBuilder = require('systemjs-builder');
var tsProject = ts.createProject("tsconfig.json");
gulp.task("default", function () {
    return tsProject.src()
        .pipe(tsProject())
        .js.pipe(gulp.dest("dist"));
});
