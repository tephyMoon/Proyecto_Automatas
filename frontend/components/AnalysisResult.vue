<script setup lang="ts">
import type { LexicalReport } from '@/types/lexical'

defineProps<{
  report: LexicalReport | null
}>()
</script>

<template>
  <div class="mt-6 grid md:grid-cols-2 gap-6" v-if="report">
    <div class="p-4 rounded-2xl border border-primary bg-primary/20">
      <h3 class="font-semibold mb-2">Resumen</h3>
      <ul class="text-sm space-y-1 opacity-90">
        <li>Total de palabras: <b>{{ report.totalWords }}</b></li>
        <li>Palabra más repetida: <b>{{ report.topWord?.[0] }}</b> ({{ report.topWord?.[1] }})</li>
        <li>Palabra menos repetida: <b>{{ report.leastWord?.[0] }}</b> ({{ report.leastWord?.[1] }})</li>
      </ul>
    </div>
    <div class="p-4 rounded-2xl border border-primary bg-primary/20">
      <h3 class="font-semibold mb-2">Detalles</h3>
      <pre class="text-xs whitespace-pre-wrap opacity-90">{{ report.breakdown }}</pre>
    </div>
  </div>
  <div v-else class="mt-6 p-4 rounded-2xl border border-primary bg-primary/10 text-sm opacity-80">
    No hay resultados todavía. Sube un archivo y presiona “Procesar”.
  </div>
</template>
