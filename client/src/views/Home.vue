<template>
  <div class="home">
    <section class="bannner text-center">
      <h1>
        Mini Stack Overflow replica used as a boilerplate project for integrating
        Vue, ASP.NET Core and SignalR
      </h1>
      <button v-b-modal.postQuestionModal class="btn btn-secondary">
        <i class="fas fa-question-circle"/> Ask a Question
      </button>
    </section>
    <Questions :questions="questions" />
    <post-question-modal />
  </div>
</template>

<script>
// @ is an alias to /src
import { mapGetters, mapActions } from "vuex";
import PostQuestionModal from "@/components/PostQuestionModal";
import Questions from "@/components/Questions"
export default {
  name: "Home",
  components: {
    PostQuestionModal,
    Questions
  },
  computed: {
    ...mapActions(["getQuestions"]),
    ...mapGetters(["questions"])
  },
};
</script>
