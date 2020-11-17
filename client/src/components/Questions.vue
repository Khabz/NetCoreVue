<template>
  <div class="questions mt-5" v-if="questions">
    <div v-for="(question, index) in questions" :key="index">
      <b-card border-variant="dark">
        <div class="content">
          <h3 class="text-center scoring">
            <button
              class="btn btn-link btn-lg p-0 d-block mx-auto"
              @click.stop="onUpvote"
            >
              <i class="fas fa-sort-up" />
            </button>
            <span class="d-block mx-auto">{{ question.score }}</span>
            <button
              class="btn btn-link btn-lg p-0 d-block mx-auto"
              @click.stop="onDownvote"
            >
              <i class="fas fa-sort-down" />
            </button>
          </h3>
          <b-card-text class="question-body">{{ question.body }}</b-card-text>
        </div>
        <div class="footer mt-3">
            <a href="">
                View Question
                <b-badge class="badge badge-info"></b-badge>
            </a>
            <p class=" float-right">
                <i class="fas fa-clock"/> {{ question.postedOn | moment("from", "now", true) }}
            </p>
        </div>
      </b-card>
    </div>
  </div>
</template>

<script>
export default {
  props: ["questions"],
  mounted() {
      console.log(this.questions)
  }
};
</script>

<style>
.content {
  display: inline-flex;
}
.question-body {
  margin-left: 100px;
  margin-top: 35px;
  text-align: center;
}
</style>
