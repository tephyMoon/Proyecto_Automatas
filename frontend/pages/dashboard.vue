<script setup lang="ts">
definePageMeta({
  layout: 'default',
  middleware: ['require-auth']
})

import FileUpload from '@/components/FileUpload.vue'
import LanguageSelector from '@/components/LanguageSelector.vue'
import AnalysisResult from '@/components/AnalysisResult.vue'
import { analyzeText } from '@/utils/lexicalAnalysis'
import type { LexicalReport } from '@/types/lexical'

const lang = ref('Español')
const rawText = ref<string>('')
const report = ref<LexicalReport | null>(null)

const process = () => {
  // Simulación local (mock). Reemplazar con llamada a backend en el futuro.
  report.value = analyzeText(rawText.value)
}
</script>

<template>
  <section class="space-y-4">
    <h2 class="text-2xl font-semibold">Dashboard</h2>

    <div class="grid md:grid-cols-2 gap-4">
      <FileUpload @file:selected="(t) => (rawText = t)" />
      <LanguageSelector v-model="lang" />
    </div>

    <button class="px-4 py-2 rounded-lg bg-accent/80 hover:bg-accent/90" @click="process">
      Procesar
    </button>

    <AnalysisResult :report="report" />
  </section>
</template>
